### Table of contents
1. [Introduction](#introduction)
2. [Design](#design)
    1. [User stories](#user-stories)
    
# Introduction
An application allowing users to track progress of an ongoing project, supporting users, roles, permissions and notifications. This project should utilise:
- Agile development methodology
- Frontend SPA (Single Page Application)
- Backend API
- Unit testing
- DevOps CI/CD process with automated testing
    
## Design
### User Stories

It is **expected** that the system will **include basic tracking functionalities** without having to explicitly mention it, such as: 
- Registering a user within the system 
- Authenticating a user within the system
- Performing basic CRUD abilities (Create, Read, Update, Delete) on:
  - Projects
  - Tickets (incl. closing and reopening)
  - Ticket comments

| Title           | User story                                   | Acceptance Criteria      |
| -------------   | -------------------------------------------- | ------------------------ |
| Inviting users to a project | As a user, I want to invite a colleague to my project and the recipients should be notified of a recent invitation. | The system must allow users within a project to invite other users in real-time to work on a project collaboratively. |
| Kicking users from a project | As a user, I want to have the ability to kick a user out of the project. | The system must allow users within a project to kick other users who are present in the project. |
| Roles per project | As a project owner, I want to assign roles to various users within a project. Specific roles, such as Admin, should have access to more of the system. | The system must incorporate roles per project, specific roles must have additional functionalities within the system, e.g. Kicking users can only be executed by project admins. |
| Role permissions | As an admin of a project, I want the ability to customise what role has access to functionalities within the project. | The system must incorporate role-based permissions per project, an admin or owner of a project should be able to customise what roles have access to functionalities. |
| Project dashboard | As a user, I want to view a dashboard within each project which gives quick insights about the project progress. | The system must allow users to view a dashboard for any project, a dashboard should use graphs to give project users an insight into a project. |
| Ticket assignee's | As a user, I want to be able to assign a ticket to a project user and notify the user of this event. | The system must allow users to assign a ticket to a user within a project. When assigning to a user, the recipient should be notified in real-time of this event. |
| Ticket history | As a user, I want to view the history of the tickets that have been created. | The system must allow project users to view a history of all changes, and the time of change, to a ticket. |
| Text-formatting | As a user, when creating tickets or comments, I want the ability to style the text in a simple manner. | The system must allow users to format text on tickets and comments using markdown, or a rich-text editor. |
| Ticket labels | As a user, when creating a ticket I want to easily allow other collaborators to understand the premise of a ticket using labels. | The system must allow users to assign multiple labels to a ticket, labels such as: bug, documentation, enhancement etc. |
