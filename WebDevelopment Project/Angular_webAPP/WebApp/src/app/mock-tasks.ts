import { Department } from './department';
import { Employees } from './Mock-employees';
import { DEPARTMENT } from './mock-departments';
import { Task } from './task';

export const TASKS: Task[] = [
    { task_id: 10, title: "Do the assignment", TaskDepartment: DEPARTMENT[1],TaskEmployeesIDs: [1] ,deadline: new Date(2020, 4, 4) },
    { task_id: 11, title: "Complete Web2",     TaskDepartment: DEPARTMENT[2],TaskEmployeesIDs: [4] ,deadline: new Date(2020, 4, 6) },
    { task_id: 12, title: "Complete Python assignment",TaskDepartment: DEPARTMENT[3],TaskEmployeesIDs: [1,9] , deadline: new Date(2020, 4, 7) },
    { task_id: 13, title: "Merge the branches",TaskDepartment: DEPARTMENT[4],TaskEmployeesIDs: [3,7,8,9] , deadline: new Date(2020, 4, 8) },
    { task_id: 14, title: "Send an email to the teacher",TaskDepartment: DEPARTMENT[1],TaskEmployeesIDs: [1,2,3,4,6] , deadline: new Date(2020, 4, 9) },
    { task_id: 15, title: "Complete week3 OOD assignment",TaskDepartment: DEPARTMENT[1],TaskEmployeesIDs: [2,3,4] , deadline: new Date(2020, 4, 12) },
    { task_id: 16, title: "Pay your bills",TaskDepartment: DEPARTMENT[8],TaskEmployeesIDs: [2,5] , deadline: new Date(2020, 4, 15) },
    { task_id: 17, title: "Update your app",TaskDepartment: DEPARTMENT[7],TaskEmployeesIDs: [4,7] , deadline: new Date(2020, 4, 16) },
    { task_id: 18, title: "Get the data",TaskDepartment: DEPARTMENT[8],TaskEmployeesIDs: [7,2,5] , deadline: new Date(2020, 4, 5) },
    { task_id: 19, title: "Comment your code",TaskDepartment: DEPARTMENT[5],TaskEmployeesIDs: [9,8,7] , deadline: new Date(2020, 4, 4) },
    { task_id: 20, title: "Train in Tableau",TaskDepartment: DEPARTMENT[1],TaskEmployeesIDs: [6,5,4,2,1] , deadline: new Date(2020, 4, 6) },

];