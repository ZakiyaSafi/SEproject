#SE Project 2018

Zakiya Safi             1319070
Ahmed Ali Karani         1036074
Zubair Ahmed Bulbulia     1249593
Kyle Morris             1112649

Project definition: 
Students Marks/Record Management System

Expanded project description:
The task is to develop a web-based system with the capabilities of being able to record marks of various assessments, for a multitude of students. It will include a database for all student marks. There must exist the capability for course coordinators to be able to access, edit and update marks on the database, as well as being able to view student marks. From the student side, they need to be able to view their marks from the 'portal'. They must also have the ability to query a certain assignment mark if they believe there to be an error with it. 

Features to consider:

Student perspective: 

The Student must be able to track their progress throughout the duration of a course. The Student must be provided with minimum percentages required for future assessments in order to pass the course. The Student must also be provided with the functionality of querying marks for assessments. Students must have the limitation of not having access to other students' marks, and not being able to make modifications to their own marks. 

Course Coordinator perspective:

The Course Coordinator(CC) should have the ability to add assessments to the database, as well as define the weighting of the assessments to enable students to see how much they contribute to the overall mark. The UI should make it easy to enter marks for students’ assessments, whether for individual students or for the entire class. 
The course coordinator should be able to print a table of students and their respective marks for a course. 
The course coordinator must be able to generate a statistical summary of the performance of the student/s for each assessment. 
The course coordinator must also be able to view a projected pass rate for the students based on marks that have been accumulated so far. 
Additionally, the coordinator must also be able to record any offence of a student occurring during the running of the course.

School Administrator perspective:

The School Administrator(SA) must be able to register students for their courses.
As with a CC, the SA should be able to print a table of students and their respective marks for a course, as well as be able to generate a statistics summary of the students performance.
The SA must also be able to view a comparative chart of students marks of a particular group. Also the SA must be able to view a histogram of a students assessments marks across all courses.
Additionally, the coordinator must also be able to view any recorded offence of a student.
Lastly, the SA must be able to compare performance in a course across different years.

Front end description:
The interface needs to be simple, creative and appealing. The front end will use different technologies to deliver an interface that provides users with the relevant features and information required.

The front end will have three different perspectives catering to the Students, Course Administrators and Heads of School. All users will be prompted with a login screen when accessing the portal which requires a username and password. The user will then be directed to the portal and will have functionality pertaining to the user type associated with their username. 

The front end will:
Provide a somewhat 'read-only' display to students, allowing them to only view marks – ensuring the marks cannot be edited by them.
Provide front end functionality for Course Coordinators for entering marks, registration, printing tables of marks, generating summary statistics and the projected pass rate.
Provide front end functionality for School Administrators for registration, generating and viewing summary statistics/charts and check/record offences.
Use colour when displaying data to students to show different levels of performance in assessments in the course. 
Use mathematical tools to provide a detailed breakdown of marks. This can be implemented by means of graphs, charts, and numerical figures. 
Have an easy to use interface, again using different colours to show where marks have not been entered for certain students.

Back end tasks and description:
The back end will be responsible for the complexity involved in providing important system features. The back end will mainly rely on a well designed and implemented database structure. The database will store the relevant data and will deliver information to users as required by the accompanied scripting.

The back end will be developed using an ASP.NET MVC frameworks, using technologies such as C#, HTML, and CSS.

Required inputs:

Student:
-Student ID and password.
-Query a mark

Course Coordinator:
-Course Coordinator ID and Password
-Assessments of course 
-Weightings of assessments 
-Results of assessments of each student

School Administrator:
-School Administrator ID and Password 
-Registration details for registering students for a course 

The following users of the system are involved with back end tasks and as such will not directly contribute to the the system as end-users. However, their involvement is as follows:

Database Administrator:
Will have the ability to edit marks of a current assessment and input new marks as a whole. Defensive coding must be incorporated to avoid errors with null values when attempting calculations, and also to avoid producing incorrect results and statistics. The administrator must maintain, backup and improve the database where necessary.

System Admin:
This responsibility includes overseeing both the monitoring and security of the system, and ensuring the system is correctly configured – enabling smooth usage.

Outputs to be displayed:
Student: 
-Assessment results for each course 
-Statistics for each assessment 
-Required mark necessary to achieve a pass per course 

Course Coordinator: 
-Table of students and their marks 
-Summary statistics of performance of students 
-Projected pass rate based on assessment marks accumulated 

School Administrator: 
-Table of students and their marks 
-Summary statistics of performance of students 
-Comparative chart of assessment marks of selected students in a particular group 
-Histogram of assessment marks of all courses taken by a specific student 
-Recorded offenses 
-Performances in the same course across different years 

Front end UI needs to combine with data from back end databases in order to create a visually appealing, easy to navigate portal to achieve the above mentioned tasks.

Responsibilities of group members:
Given the large scale and complexity of the system to be designed and implemented, responsibilities need to be assigned to group members based on strengths as well as experience in the different aspects of the project.

Zakiya Safi: Programming lead 
Ahmed Ali Karani: Database design and implementation lead 
Zubair Ahmed Bulbulia: UI and UX 
Kyle Morris: Documentation and reporting 