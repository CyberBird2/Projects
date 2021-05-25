import { Department } from './department';
export class Employee {
    id: number;
    gender: string;
    first_name: string;
    last_name: string;
    dob: Date;
    EmployeeDepartment:Department;
    constructor( id: number, gender:string, firstName:string, lastName: string, dob:Date,EmployeeDepartment:Department) {
        this.id = id;
        this.gender = gender;
        this.first_name = firstName;
        this.last_name = lastName;
        this.dob = dob;
        this.EmployeeDepartment=EmployeeDepartment;
    }
    
}