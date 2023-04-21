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
    Name VARCHAR(30) UNIQUE NOT NULL CHECK(LENGTH(Name)>5),
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

INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (1, 'Project A', 'A project to develop a new e-commerce platform', TO_DATE('2023-01-01', 'YYYY/MM/DD'), TO_DATE('2023-06-30','YYYY/MM/DD'), 'Extended', 100000);
INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (2, 'Project B', 'A project to develop a mobile app', TO_DATE('2023-02-01', 'YYYY/MM/DD'), TO_DATE('2023-08-31','YYYY/MM/DD'), 'Created', 50000);
INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (3, 'Project C', 'A project to upgrade legacy systems', TO_DATE('2024-07-01', 'YYYY/MM/DD'), TO_DATE('2024-12-31','YYYY/MM/DD'), 'Started', 200000);
INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (4, 'Project D', 'A project to implement a new CRM system', TO_DATE('2023-06-01', 'YYYY/MM/DD'), TO_DATE('2024-03-31', 'YYYY/MM/DD'), 'Created', 150000);
INSERT INTO PROJECTS (ProjId, ProjectName, ProjectDescription, StartDate, EndDate, Status, ExpectedCost) VALUES (5, 'Project E', 'A project to migrate to a new cloud platform', TO_DATE('2024-05-01', 'YYYY/MM/DD'), TO_DATE('2025-01-31','YYYY/MM/DD'), 'Extended', 75000);

INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (1, 'John', 'Doe', 'Java', 30, 1);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (2, 'Jane', 'Smith', 'Python', 25, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (3, 'Bob', 'Johnson', 'C#', 35, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (4, 'Alice', 'Williams', 'JavaScript', 28, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (5, 'David', 'Brown', 'PHP', 30, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (6, 'John', 'Selby', 'PHP', 25, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (7, 'John', 'Doe', 'Java Developer', 25, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (8, 'Jane', 'Doe', 'Frontend Developer', 28, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (9, 'Bob', 'Smith', 'Data Scientist', 32, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (11, 'Alice', 'Johnson', 'DevOps Engineer', 30, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (12, 'Michael', 'Brown', 'UI/UX Designer', 27, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (13, 'David', 'Lee', 'Mobile Developer', 26, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (14, 'Emily', 'Taylor', 'Software Tester', 29, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (15, 'Daniel', 'Kim', 'Backend Developer', 31, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (16, 'Olivia', 'Chen', 'Full Stack Developer', 28, NULL);
INSERT INTO DEVELOPERS (DevId, FirstName, LastName, Specialization, Age, ProjectId) VALUES (17, 'Jack', 'Wang', 'Cloud Architect', 33, NULL);


INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (1, 'Implement Login', 'Implement the login feature for the web app',  TO_DATE('2023-04-21','YYYY/MM/DD'), 8, 'Created', 'High', 1, 1);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (2, 'Design Landing Page', 'Design the landing page for the website',  TO_DATE('2023-04-22','YYYY/MM/DD'), 10, 'Created', 'High', 1, 2);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (3, 'Create Database Schema', 'Create the database schema for the web app',  TO_DATE('2023-04-23','YYYY/MM/DD'), 12, 'Created', 'High', 2, 3);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (4, 'Deploy to Production', 'Deploy the web app to production environment',  TO_DATE('2023-04-24','YYYY/MM/DD'), 4, 'Created', 'Medium', 2, 4);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (5, 'Optimize UI Performance', 'Optimize the performance of the UI components',  TO_DATE('2023-04-25','YYYY/MM/DD'), 6, 'Created', 'Medium', 3, 5);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (6, 'Create Mobile UI', 'Create the mobile UI for the web app',  TO_DATE('2023-04-26','YYYY/MM/DD'), 8, 'Created', 'High', 3, 6);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (7, 'Write Test Cases', 'Write test cases for the web app',  TO_DATE('2023-04-27','YYYY/MM/DD'), 10, 'Created', 'Medium', 4, 7);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (8, 'Refactor Backend Code', 'Refactor the backend code for better performance',  TO_DATE('2023-04-28','YYYY/MM/DD'), 12, 'Created', 'High', 4, 8);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (9, 'Add Payment Gateway', 'Add payment gateway integration to the web app',  TO_DATE('2023-04-29','YYYY/MM/DD'), 8, 'Created', 'High', 5, 9);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (10, 'Configure AWS Environment', 'Configure the AWS environment for the web app',  TO_DATE('2023-04-30','YYYY/MM/DD'), 10, 'Created', 'Medium', 5, NULL);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (11, 'Design Database Model', 'Design the database model for the web app',  TO_DATE('2023-05-01','YYYY/MM/DD'), 15, 'Finished', 'Low', 5, NULL);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (12, 'Add Push Notifications', 'Add push notifications to the mobile app',  TO_DATE('2023-05-02','YYYY/MM/DD'), 6, 'Created', 'Medium', 1, 1);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (13, 'Write Documentation', 'Write documentation for the web app',  TO_DATE('2023-05-03','YYYY/MM/DD'), 8, 'Created', 'Medium', 2, 2);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (14, 'Test Payment Gateway', 'Test payment gateway integration for the web app',  TO_DATE('2023-05-04','YYYY/MM/DD'), 4, 'Created', 'Low', 2, NULL);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (15, 'Integrate Analytics', 'Integrate analytics for the web app',  TO_DATE('2023-05-05','YYYY/MM/DD'), 6, 'Created', 'Medium', 1, 4);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (16, 'Create REST APIs', 'Create REST APIs for the web app',  TO_DATE('2023-05-06','YYYY/MM/DD'), 10, 'Created', 'High', 3, NULL);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (17, 'Write Unit Tests', 'Write unit tests for the web app',  TO_DATE('2023-05-07','YYYY/MM/DD'), 8, 'Created', 'High', 3, NULL);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (18, 'Create UI Components', 'Create UI components for the web app',  TO_DATE('2023-05-08','YYYY/MM/DD'), 12, 'Created', 'High', 4, NULL);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (19, 'Integrate Social Media', 'Integrate social media sharing for the web app',  TO_DATE('2023-05-09','YYYY/MM/DD'), 6, 'Created', 'Medium', 4, 8);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (20, 'Optimize Database Queries', 'Optimize the performance of database queries',  TO_DATE('2023-05-10','YYYY/MM/DD'), 10, 'Created', 'High', 4, 9);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId)
VALUES (21, 'Task A', 'Develop login functionality', TO_DATE('2023-07-01','YYYY/MM/DD'), 20, 'Started', 'High', 5, 1);

INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId) 
VALUES (22, 'Task B', 'Design UI for mobile app', TO_DATE('2023-07-01','YYYY/MM/DD'), 15, 'Created', 'Medium', 2, 2);

COMMIT;