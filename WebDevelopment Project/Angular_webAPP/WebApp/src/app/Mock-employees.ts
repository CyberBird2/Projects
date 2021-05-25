import { DEPARTMENT } from './mock-departments';

import { Employee } from './employee';
export const Employees: Employee[] = [
  new Employee(1,'M', 'Wondimu ','wo',new Date(2020, 4, 4),DEPARTMENT[1]),
  new Employee(2,'M', 'Alex ','SP',new Date(2020, 4, 4) ,DEPARTMENT[2]),
  new Employee(3,'f', 'Ralia ','Ralia',new Date(2020, 4, 4),DEPARTMENT[4] ),
  new Employee(4,'f', 'Nancy ','Ajram',new Date(2020, 4, 4),DEPARTMENT[4] ),
  new Employee(5,'m', 'Delal ','goggle',new Date(2020, 4, 4) ,DEPARTMENT[3]),
  new Employee(6,'f', 'Saly ','Nora',new Date(2020, 4, 4) ,DEPARTMENT[2]),
  new Employee(7,'f', 'Sonia ','Moris',new Date(2020, 4, 4) ,DEPARTMENT[5]),
  new Employee(8,'m', 'Obaid','Gh',new Date(2020, 4, 4) ,DEPARTMENT[5]),
  new Employee(9,'m', 'Abdulah ','Abdulah',new Date(2020, 4, 4) ,DEPARTMENT[3]),
  new Employee(10,'m', 'Shadi','sorany',new Date(2020, 4, 4),DEPARTMENT[2])
  
  ];