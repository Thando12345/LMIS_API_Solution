USE LMS_Db; -- Ensure you are using the correct database

-- Create the LearnerEnrTbl table if it doesn't already exist
IF OBJECT_ID('[dbo].[LearnerEnrTbl]', 'U') IS NULL
BEGIN
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
        [QualificationDocumentPath] VARCHAR(255), -- Path to qualification document (max 255 characters)
        [CourseId] INT NOT NULL, -- Foreign Key to Course table
        CONSTRAINT FK_LearnerEnrTbl_Course FOREIGN KEY (CourseId) REFERENCES [dbo].[Course]([CourseId])
    );
END;


-- Create the Course table if it doesn't already exist
IF OBJECT_ID('[dbo].[Course]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Course]
    (
        [CourseId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key with auto-incrementing ID
        [Name] VARCHAR(100) NOT NULL, -- Course name (max 100 characters)
        [Type] VARCHAR(50) NOT NULL, -- Course type (e.g., "Accredited", "Non-Accredited")
        [Credits] INT NOT NULL, -- Course credits
        [NQFLevel] INT NOT NULL, -- NQF Level
        [IsAccredited] BIT NOT NULL, -- Is the course accredited
        [AccreditationBody] VARCHAR(200), -- Accreditation body (max 200 characters)
        [AccreditationNumber] VARCHAR(100) -- Accreditation number (max 100 characters)
    );
END;

-- Create the UnitStandard table if it doesn't already exist
IF OBJECT_ID('[dbo].[UnitStandard]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[UnitStandard]
    (
        [UnitStandardId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key with auto-incrementing ID
        [Name] VARCHAR(100) NOT NULL, -- Unit standard name (max 100 characters)
        [Id] VARCHAR(50) NOT NULL, -- Unit standard ID or code (max 50 characters)
        [Credits] INT NOT NULL, -- Credits for the unit standard
        [NQFLevel] INT NOT NULL, -- NQF Level for the unit standard
        [CourseId] INT NOT NULL, -- Foreign key to Course table
        CONSTRAINT FK_UnitStandard_Course FOREIGN KEY (CourseId) REFERENCES [dbo].[Course]([CourseId])
    );
END;
--New schema   14-01-2025

-- Ensure the Practitioners table exists
IF OBJECT_ID('[dbo].[Practitioners]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Practitioners]
    (
        [PractitionerId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key
        [Name] VARCHAR(255) NOT NULL, -- Practitioner Name
        [Surname] VARCHAR(255) NOT NULL, -- Practitioner Surname
        [IDNumber] VARCHAR(13) NOT NULL UNIQUE, -- Unique ID Number
        [Role] VARCHAR(50) NOT NULL, -- Practitioner Role
        [CourseId] INT, -- Foreign Key to Course Table
        CONSTRAINT FK_Practitioners_Course FOREIGN KEY (CourseId) REFERENCES [dbo].[Course]([CourseId])
    );
END;

-- Ensure the PractitionerRoles table exists
IF OBJECT_ID('[dbo].[PractitionerRoles]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[PractitionerRoles]
    (
        [RoleId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key
        [RoleName] VARCHAR(50) NOT NULL -- Role Name (e.g., Facilitator, Assessor, Moderator)
    );
END;

-- Ensure the PractitionerCourseAssignments table exists
IF OBJECT_ID('[dbo].[PractitionerCourseAssignments]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[PractitionerCourseAssignments]
    (
        [AssignmentId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key
        [PractitionerId] INT NOT NULL, -- Foreign Key to Practitioners
        [CourseId] INT NOT NULL, -- Foreign Key to Course
        [RoleId] INT NOT NULL, -- Foreign Key to PractitionerRoles
        CONSTRAINT FK_Assignments_Practitioner FOREIGN KEY (PractitionerId) REFERENCES [dbo].[Practitioners]([PractitionerId]),
        CONSTRAINT FK_Assignments_Course FOREIGN KEY (CourseId) REFERENCES [dbo].[Course]([CourseId]),
        CONSTRAINT FK_Assignments_Role FOREIGN KEY (RoleId) REFERENCES [dbo].[PractitionerRoles]([RoleId])
    );
END;


--New Schema 2025/01/15
-- Step 1: Creating the Learners table (if not exists)
IF OBJECT_ID('[dbo].[Learners]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Learners]
    (
        [LearnerId] INT IDENTITY(1,1) PRIMARY KEY,
        [LearnerName] NVARCHAR(255) NOT NULL
    );
END;

-- Step 2: Creating the Users table for Facilitators, Assessors, and Moderators (if not exists)
IF OBJECT_ID('[dbo].[Users]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Users]
    (
        [UserId] INT IDENTITY(1,1) PRIMARY KEY,
        [UserName] NVARCHAR(255) NOT NULL,
        [Role] NVARCHAR(50) NOT NULL -- Facilitator, Assessor, Moderator, etc.
    );
END;

-- Step 3: Creating the Interventions table (if not exists)
IF OBJECT_ID('[dbo].[Interventions]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Interventions]
    (
        [InterventionId] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
        [CourseId] INT NOT NULL, -- Foreign Key to Courses table
        [Funder] NVARCHAR(255) NOT NULL,
        [StartDate] DATE NOT NULL,
        [EndDate] DATE NOT NULL,
        [FacilitatorId] INT NOT NULL, -- Foreign Key to Users table
        [AssessorId] INT NOT NULL, -- Foreign Key to Users table
        [ModeratorId] INT NOT NULL, -- Foreign Key to Users table
        CONSTRAINT FK_Interventions_Course FOREIGN KEY (CourseId) REFERENCES [dbo].[Course]([CourseId]),
        CONSTRAINT FK_Interventions_Facilitator FOREIGN KEY (FacilitatorId) REFERENCES [dbo].[Users]([UserId]),
        CONSTRAINT FK_Interventions_Assessor FOREIGN KEY (AssessorId) REFERENCES [dbo].[Users]([UserId]),
        CONSTRAINT FK_Interventions_Moderator FOREIGN KEY (ModeratorId) REFERENCES [dbo].[Users]([UserId])
    );
END;

-- Step 4: Creating the LearnerInterventionLinks table (if not exists)
IF OBJECT_ID('[dbo].[LearnerInterventionLinks]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[LearnerInterventionLinks]
    (
        [LinkId] INT IDENTITY(1,1) PRIMARY KEY,
        [LearnerId] INT NOT NULL, -- Foreign Key to Learners table
        [InterventionId] INT NOT NULL, -- Foreign Key to Interventions table
        CONSTRAINT FK_Learner_Intervention FOREIGN KEY (LearnerId) REFERENCES [dbo].[Learners]([LearnerId]),
        CONSTRAINT FK_Intervention_Learner FOREIGN KEY (InterventionId) REFERENCES [dbo].[Interventions]([InterventionId])
    );
END;


--New test case 2025/01/16


-- Step 4: Creating the Certifications table
IF OBJECT_ID('[dbo].[Certifications]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Certifications]
    (
        [CertificationId] INT IDENTITY(1,1) PRIMARY KEY,
        [LearnerId] INT NOT NULL, -- Foreign Key to Learners
        [InterventionId] INT NOT NULL, -- Foreign Key to Interventions
        [CertificateNumber] NVARCHAR(50) UNIQUE NOT NULL, -- Auto-allocated
        [IssueDate] DATE NOT NULL DEFAULT GETDATE(),
        [IsCompetent] BIT NOT NULL DEFAULT 0, -- 1 = Competent, 0 = Not Competent
        [DeliveryNoteGenerated] BIT NOT NULL DEFAULT 0,
        CONSTRAINT FK_Certifications_Learner FOREIGN KEY (LearnerId) REFERENCES [dbo].[Learners]([LearnerId]),
        CONSTRAINT FK_Certifications_Intervention FOREIGN KEY (InterventionId) REFERENCES [dbo].[Interventions]([InterventionId])
    );
END;

-- Step 5: Creating the BatchCertificates table
IF OBJECT_ID('[dbo].[BatchCertificates]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[BatchCertificates]
    (
        [BatchId] INT IDENTITY(1,1) PRIMARY KEY,
        [InterventionId] INT NOT NULL, -- Foreign Key to Interventions
        [CertificateNumbers] NVARCHAR(MAX) NOT NULL, -- Comma-separated certificate numbers
        [GeneratedDate] DATE NOT NULL DEFAULT GETDATE(),
        [ElectronicSignature] BIT NOT NULL DEFAULT 0, -- 1 = Signature Included, 0 = Not Included
        CONSTRAINT FK_BatchCertificates_Intervention FOREIGN KEY (InterventionId) REFERENCES [dbo].[Interventions]([InterventionId])
    );
END;

-- Step 6: Creating the Reports table
IF OBJECT_ID('[dbo].[Reports]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Reports]
    (
        [ReportId] INT IDENTITY(1,1) PRIMARY KEY,
        [ReportType] NVARCHAR(255) NOT NULL, -- Assessment, Moderator, All Register, etc.
        [GeneratedDate] DATE NOT NULL DEFAULT GETDATE(),
        [Content] NVARCHAR(MAX) NOT NULL -- JSON or Text content of the report
    );
END;