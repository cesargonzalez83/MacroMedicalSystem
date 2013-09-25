SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO

PRINT N'Updating ServiceLockTypeEnum description'
GO

update [ServiceLockTypeEnum] set LongDescription='This service periodically synchronizes the deletion status of Authority Groups on the Enterprise Services with Data Access granted to studies on the ImageServer.' where Lookup='SyncDataAccess'
GO

PRINT N'Adding ImplicitOnly column'
GO
ALTER TABLE [ServerSopClass] ADD [ImplicitOnly] bit NOT NULL DEFAULT(0)
GO

PRINT N'Updating ImplicitOnly column'
GO
UPDATE [ServerSopClass] SET [ImplicitOnly]=1 WHERE [SopClassUid]='1.2.840.10008.5.1.4.1.1.481.3'
GO

IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO


IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT 'The database update succeeded'
COMMIT TRANSACTION
END
ELSE PRINT 'The database update failed'
GO
DROP TABLE #tmpErrors
GO
