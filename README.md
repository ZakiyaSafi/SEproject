#SE Project 2018

Zakkiya Safi
Ahmed Ali Karani
Zubair Ahmed Bulbulia
Kyle Morris

Project definition: Students Marks/Record Management System

Expanded project description:

Our task requirement is to develop a web-based system with the capabilities of being able to record marks of various assessments, for a multitude of students. It will thus function as a database for all student marks. There must exist the capability for course coordinators to be able to access, edit and update marks on the database, as well as being able to view student marks. From the student side, they need to be able to view their marks from the 'portal'. They must also have the ability to query a certain assignment mark if they believe there to be an error with it. Students must have the limitation of not having access to other students' marks, and not being able to make modifications to their own marks. 


Features to consider:

Student perspective:
 
Students must be able to track their progress throughout the duration of a course.
 The UI must be simple, clear and appealing. It could be worth introducing colour scheming to differentiate when a student is failing, close to passing, passing, doing well, and excelling.
Implementation of graphing tools to show where a students marks increased or declined, as well as to show overall progress.
A simple calculator could be implemented which combines the scores of all completed assessments to date, and outputs the required mark for the remainder of the course in order to achieve a user defined mark/ to simply pass.
Allow a student to query when they believe a mark to be incorrect – but keep track of each instance a student requests such to determine priority and when students are simply 'trying their luck'.

Administrator perspective:

The ability to add assessments to the database, as well as define the weighting of the tests to enable students to see how much it contributes to the overall mark.
Use math tools to provide a detailed breakdown of marks: Allow the course coordinator to view which assessments students did well in, and which were problematic. This can be implemented by means of graphs, charts, and numerical figures.
Easy to use interface, again using colour implementation to show where marks have not been entered for certain students.
Incorporate records from the course in previous years (if accessible), to compare student & score performances.
Record any offence of a student occuring during the running of the course.



Front end description:

Interface needs to be simple, creative and appealing.
Initial screen must be a 'login' portal where a 'id' number and password is required to gain access to the marks corresponding to that login information.
The 'main'/'home' screen must provide an overview of marks and allow the student to access individual test scores, as well as the previously defined 'query' option for a particular test.
Provide a somewhat 'read-only' display to students, allowing them to only view marks – ensuring the cannot be edited by them.


Back end tasks and description:

This primarily entails the database and its related operations. The database content needs to be correctly captured and stored to prevent errors when producing outputs on the portal. Specifications and relationships must be carefully defined – primary key being student id, a 1-many relationship between students and assessments, etc. Also need to have the ability to insert marks for a new assessment not yet stored on the database and associate it to the relevant student id's.

Required inputs:

Student:
id and password will be the only required fields from student, providing them access to their marks. After this, will be able to view what marks are needed in the remaining assessments to achieve a pass (or distinction).

Database Administrator:
Will have the ability to edit marks of a current test and input new marks as a whole. Defensive coding must be incorporated to avoid errors with null values when attempting calculations, and also to avoid producing incorrect results and statistics. The administrator must maintain, backup and improve the database where necessary.

System Admin:
This responsibility includes overseeing the security of the system, and ensuring the system is correctly configured – enabling smooth usage.

Outputs to be displayed:
GUI needs to combine with data from the db in order to create a visually appealing, easy to navigate portal to achieve the above mentioned tasks.


