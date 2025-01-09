USE LMS_Db; -- Ensure we are using the correct database

CREATE TABLE [dbo].[LearnerEnrTbl]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key with auto-incrementing ID
    [Surname] VARCHAR(255) NOT NULL, -- Surname (max 255 characters)
    [FullNames] VARCHAR(255) NOT NULL, -- Full names (max 255 characters)
    [IdentityNumber] VARCHAR(13) NOT NULL, -- Identity number (max 13 characters)
    [AlternateID] VARCHAR(15), -- Alternate ID (max 15 characters)
    [Nationality] VARCHAR(50) NOT NULL, -- Nationality (max 50 characters)
    [HomeLanguage] VARCHAR(50) NOT NULL, -- Home language (max 50 characters)
    [Age] INT NOT NULL, -- Age (integer)
    [Gender] VARCHAR(10) NOT NULL, -- Gender (max 10 characters)
    [Race] VARCHAR(50) NOT NULL, -- Race (max 50 characters)
    [DisabilityStatus] VARCHAR(50) NOT NULL, -- Disability status (max 50 characters)
    [EmploymentStatus] VARCHAR(50) NOT NULL, -- Employment status (max 50 characters)
    [OFOCode] VARCHAR(50) NOT NULL, -- OFO code (max 50 characters)
    [CompanyName] VARCHAR(255) NOT NULL, -- Company name (max 255 characters)
    [HomeAddress] VARCHAR(255) NOT NULL, -- Home address (max 255 characters)
    [PostAddress] VARCHAR(255) NOT NULL, -- Postal address (max 255 characters)
    [PhoneNumber] VARCHAR(15) NOT NULL, -- Phone number (max 15 characters)
    [EmailAddress] VARCHAR(255) NOT NULL, -- Email address (max 255 characters)
    [GrantContractNumber] VARCHAR(50) NOT NULL, -- Grant contract number (max 50 characters)
    [Internship] VARCHAR(255) NOT NULL, -- Internship (max 255 characters)
    [TrainingProvider] VARCHAR(255) NOT NULL, -- Training provider (max 255 characters)
    [LearningProgramme] VARCHAR(255) NOT NULL, -- Learning programme (max 255 characters)
    [StartDate] DATE NOT NULL, -- Start date
    [EndDate] DATE NOT NULL, -- End date
    [HighestEducation] VARCHAR(255) NOT NULL, -- Highest education level (max 255 characters)
    [LastSchoolAttended] VARCHAR(255) NOT NULL, -- Last school attended (max 255 characters)
    [Declaration] BIT NOT NULL, -- Declaration (boolean)
    [IdentityDocumentPath] VARCHAR(255), -- Path to identity document (max 255 characters)
    [QualificationDocumentPath] VARCHAR(255) -- Path to qualification document (max 255 characters)
);
