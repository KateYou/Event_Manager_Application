CREATE TABLE [dbo].[Vendors]
(
    [VName] VARCHAR(50) NULL, 
    [VType] NCHAR(10) NULL, 
    [VAddress] VARCHAR(50) NULL, 
    [VCity] VARCHAR(50) NULL, 
    [VState] VARCHAR(50) NULL, 
    [VZip] NCHAR(10) NULL, 
    [VContact] VARCHAR(50) NULL, 
    [VPhone] NCHAR(10) NULL, 
    [VFax] NCHAR(10) NULL, 
    [VTaxID] VARCHAR(50) NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [VInsurance] INT NULL, 
    [Attachments] IMAGE NULL, 
    [Website] VARCHAR(50) NULL 
)
