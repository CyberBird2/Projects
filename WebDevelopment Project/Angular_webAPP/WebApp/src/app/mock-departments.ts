
import { Department } from './department';

export const DEPARTMENT: Department[] =[

  new Department(1,    'ICT', 'R1', [1,2]),
  new Department(2,    'Engineering', 'R1',[1,3]),
  new Department(3,    'Humanity and social', 'R2',[1,4]),
  new Department(4,    'Agriculture', 'R2',[2,3]),
  new Department(5,    'Avation', 'R3',[4,9,6,7,4]),
  new Department(6,    'Music','R3',[1,3,7,8] ),
  new Department(7,    'Social and humanity', 'R4',[2,9,8]),
  new Department(8,    'Managment and Accounting', 'R4',[5,7,3]),
  new Department(9,    'Applied Science', 'R5',[6,5,7]),
  new Department(10,    'Facebook', 'R1',[7,8,9]),
  new Department(11,    'Tender', 'R4',[1,8])
  
  
]