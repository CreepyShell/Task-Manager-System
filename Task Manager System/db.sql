-- TMS script
--Danylo Khokhlov

DROP TABLE TASKS;

DROP TABLE DEVELOPERS;

DROP TABLE PROJECTS;

CREATE TABLE PROJECTS(
    ProjId VARCHAR(4),
    ProjectName VARCHAR(30) NOT NULL UNIQUE CHECK (LENGTH(ProjectName)>5),
    ProjectDescription VARCHAR(200),
    StartDate DATE NOT NULL,
    EndDate Date NOT NULL,
    Status VARCHAR(10) DEFAULT 'Created',
    ExpectedCost NUMBER(9,2) NOT NULL CHECK(ExpectedCost>0),
    CONSTRAINT pk_Projects PRIMARY KEY (ProjId)
);

CREATE TABLE DEVELOPERS(
    DevId VARCHAR(4),
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Specialization VARCHAR(50) NOT NULL,
    Age NUMBER(3) NOT NULL,
    Project VARCHAR(4),
    CONSTRAINT pk_Developers PRIMARY KEY(DevId),
    CONSTRAINT fk_DevProjects FOREIGN KEY (Project) REFERENCES PROJECTS(ProjId)
);

CREATE TABLE TASKS(
    TaskId VARCHAR(4),
    Name VARCHAR(20) UNIQUE NOT NULL CHECK(LENGTH(Name)>5),
    Description VARCHAR(100),
    StartDate DATE NOT NULL,
    Hours NUMBER(2) NOT NULL CHECK(Hours>0),
    Status VARCHAR(10) DEFAULT 'Created',
    Priority VARCHAR(10) NOT NULL,
    Project VARCHAR(4),
    Developer VARCHAR(4),
    CONSTRAINT pk_Tasks PRIMARY KEY(TaskId),
    CONSTRAINT fk_TaskProjects FOREIGN KEY(Project) REFERENCES PROJECTS(ProjId),
    CONSTRAINT fk_Developers FOREIGN KEY(Developer) REFERENCES DEVELOPERS(DevId)
);
