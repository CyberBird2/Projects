

export class Department {
    id: number;
    name: string;
    building: string;
    DepartmentEmployees: number[];
    
    constructor(id: number, name: string, building: string, DepartmentEmployees: number[]) {
        this.id = id;
        this.name = name;
        this.building = building;
        this.DepartmentEmployees = DepartmentEmployees;
    }
}