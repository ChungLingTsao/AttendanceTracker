## Attendance Application (IT5736: Final Assessment)
* [Assessment Requirements](#technologies)
* [Summary](#general-info)
* [Setup](#setup)

## Assessment Requirements
The assessment required us to pick a problem and design the Windows Form application to solve the selected problem. 
This assessment had strict requirements that must be met to receive full marks. Therefore, some features, especially in the Admin Page, seems so unnecessary.

## Summary
This attendance application was created to be a tool for Whitecliffe tutors that helps them track student attendance.
This application can record each student session by logging their start time and end time.

The procedure to sign in and out will be performed by the students. 
The steps required for a student will be: search for their name, select their name, press sign in/out, and hit the optional confirmation dialog.
![Imgur Image](https://i.imgur.com/HGKeKvC.png)
![Imgur Image](https://i.imgur.com/B93F5uA.png)

The application has been designed to sign in/out a student with the minimal amount of interaction as possible. Since students will be interacting with this at least twice a day, the number of actions required needs to be kept at a minimum. Hence, an auto confirmation dialog was implemented to reduce an action.
The application was designed with student interaction in mind because tutors often are too busy to keep a record of when students arrive and leave.
This is because out tutors may be holding meetings, having lunch, or may even forget to fill the attendance sheet.

The purpose of recording the start and end times of the session is because of compliance. 
Students are required to attend campus for a set amount of time due to student allowance/loan contracts, company policy, etc.
The attendance time is dependent on if the student is studying full time, part time, international, remote, pandemic, etc...

The application also has an admin mode for tutors to view the logs, insert new students into the database, and export the logs.
![Imgur Image](https://i.imgur.com/qz6Etfw.png)

## Setup
To run this project, clone the repository using Visual Studio 2019.

The connectionString needs to be edited to the location of the schema containing tables for log and student. These tables are ready to be imported with the attendance-db_2020-07-26.sql file.
