# Dimension Project




##### SQL DB configuration [ AZURE ]
### Creating an Azure SQL DB
    1. Create an azure account if you do not have one(free or paid - it is really  up to you)
    2. Log in and navigate to the dasboard 
    3. Create a new resource > select SQL Database
    4. Choose subscription & resouce group, if resource group is not available clicl 'create new' and give a name of your choice
    5. Give you DB a name and a server, if a server is not available, click 'create new' and fill in the form
      - add the following on the form to configure server:
        a. sever name
        b. server admin login
        c. password & confirm password
        d. location
        then click ok
    6. Choose to enable elastic pool if you want or leave it
    7. configure database
      - this will take you to a new UI to configure the DB 
      - depending on your account type you will be presented with types of storage options you can choose from ranging from standard to Business Critical
      - choose the amount of storage you want
    8. Once you are done you can click review and create
    9. Once a DB has been crerated you can head to resource group and view all your resources and the DB should be there too
    10. Click the DB or server to see the overview and insight on those resources
    
### Importing DATA from a CSV file to the SQL DB
    1. Create Table
    ```
    CREATE TABLE EmployeeInfo (
       EmployeeNumber INT NOT NULL,
       Age INT NOT NULL,
       Attrition VARCHAR(3) NOT NULL,
       BusinessTravel VARCHAR(250) NOT NULL,
       DailyRate INT NOT NULL,
       Department VARCHAR(250) NOT NULL,
       DistanceFromHome INT NOT NULL,
       Education INT NOT NULL,
       EducationField VARCHAR(250) NOT NULL,
       EmployeeCount INT NOT NULL,
       EnvironmentSatisfaction INT NOT NULL,
       Gender VARCHAR(6) NOT NULL,
       HourlyRate INT NOT NULL,
       JobInvolvement INT NOT NULL,
       JobLevel INT NOT NULL,
       JobRole VARCHAR(250) NOT NULL,
       JobSatisfaction INT NOT NULL,
       MaritalStatus VARCHAR(20) NOT NULL,
       MonthlyIncome FLOAT NOT NULL,
       MonthlyRate FLOAT NOT NULL,
       NumCompaniesWorked INT NOT NULL,
       Over18 VARCHAR(1)NOT NULL,
       OverTime VARCHAR(3) NOT NULL,
       PercentSalaryHike FLOAT NOT NULL,
       PerformanceRating INT NOT NULL,
       RelationshipSatisfaction INT NOT NULL,
       StandardHours INT NOT NULL,
       StockOptionLevel INT NOT NULL,
       TotalWorkingYears INT NOT NULL,
       TrainingTimesLastYear INT NOT NULL,
       WorkLifeBalance INT NOT NULL,
       YearsAtCompany INT NOT NULL,
       YearsInCurrentRole INT NOT NULL,
       YearsSinceLastPromotion INT NOT NULL,
       YearsWithCurrManager INT NOT NULL,
       PRIMARY KEY (EmployeeNumber) 
    )
```

