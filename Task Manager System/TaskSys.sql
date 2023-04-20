-- TMS script
--Danylo Khokhlov



DROP TABLE TASKS;

DROP TABLE DEVELOPERS;

DROP TABLE PROJECTS;

CREATE TABLE PROJECTS(
    ProjId NUMBER(4),
    ProjectName VARCHAR(30) NOT NULL UNIQUE CHECK (LENGTH(ProjectName)>5),
    ProjectDescription VARCHAR(200),
    StartDate DATE NOT NULL,
    EndDate Date NOT NULL,
    Status VARCHAR(10) DEFAULT 'Created',
    ExpectedCost NUMBER(9,2) NOT NULL CHECK(ExpectedCost>0),
    CONSTRAINT pk_Projects PRIMARY KEY (ProjId)
);

CREATE TABLE DEVELOPERS(
    DevId NUMBER(4),
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Specialization VARCHAR(50) NOT NULL,
    Age NUMBER(3) NOT NULL,
    ProjectId NUMBER(4),
    CONSTRAINT pk_Developers PRIMARY KEY(DevId),
    CONSTRAINT fk_DevProjects FOREIGN KEY (ProjectId) REFERENCES PROJECTS(ProjId)
);

CREATE TABLE TASKS(
    TaskId NUMBER(4),
    Name VARCHAR(20) UNIQUE NOT NULL CHECK(LENGTH(Name)>5),
    Description VARCHAR(100),
    StartDate DATE NOT NULL,
    Hours NUMBER(2) NOT NULL CHECK(Hours>0),
    Status VARCHAR(10) DEFAULT 'Created',
    Priority VARCHAR(10) NOT NULL,
    ProjectId NUMBER(4) NOT NULL,
    DeveloperId NUMBER(4),
    CONSTRAINT pk_Tasks PRIMARY KEY(TaskId),
    CONSTRAINT fk_TaskProjects FOREIGN KEY(ProjectId) REFERENCES PROJECTS(ProjId),
    CONSTRAINT fk_Developers FOREIGN KEY(DeveloperId) REFERENCES DEVELOPERS(DevId)
);

INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (1, 'Project A', 'A project to develop a new e-commerce platform', TO_DATE('2022-01-01', 'YYYY/MM/DD'), TO_DATE('2022-06-30','YYYY/MM/DD'), 'Extended', 100000);
INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (2, 'Project B', 'A project to develop a mobile app', TO_DATE('2022-02-01', 'YYYY/MM/DD'), TO_DATE('2022-08-31','YYYY/MM/DD'), 'Created', 50000);
INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (3, 'Project C', 'A project to upgrade legacy systems', TO_DATE('2023-07-01', 'YYYY/MM/DD'), TO_DATE('2022-12-31','YYYY/MM/DD'), 'Started', 200000);
INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (4, 'Project D', 'A project to implement a new CRM system', TO_DATE('2023-06-01', 'YYYY/MM/DD'), TO_DATE('2023-03-31', 'YYYY/MM/DD'), 'Created', 150000);
INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (5, 'Project E', 'A project to migrate to a new cloud platform', TO_DATE('2022-05-01', 'YYYY/MM/DD'), TO_DATE('2023-01-31','YYYY/MM/DD'), 'Extended', 75000);

INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (1, 'John', 'Doe', 'Java', 30, 1);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (2, 'Jane', 'Smith', 'Python', 25, 2);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (3, 'Bob', 'Johnson', 'C#', 35, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (4, 'Alice', 'Williams', 'JavaScript', 28, 1);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (5, 'David', 'Brown', 'PHP', 30, 3);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (6, 'John', 'Selby', 'PHP', 25, NULL);


INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId) VALUES (1, 'Task A', 'Develop login functionality', TO_DATE('2022-01-01','YYYY/MM/DD'), 20, 'Started', 'High', 1, 1);
INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId) VALUES (2, 'Task B', 'Design UI for mobile app', TO_DATE('2022-02-01','YYYY/MM/DD'), 15, 'Created', 'Medium', 2, 2);

COMMIT;