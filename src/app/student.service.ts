import { Injectable } from "@angular/core";
import { Student, Year } from "./student.model";
const STUDENTS=[
    { id: 1, name: "asfa", famalyName: "safaf", adress: "adfad", pon: 332524, avgMarks: 70, departure_date: "17/3/23", active: false, route: 2, Year: Year.B ,tests:[{code:1, description: "mate",date:'02/03/2023',mark: 90},
{code:1, description: "english",date:'14/03/2023', mark: 87}]},
 { id: 2, name: "tami", famalyName: "satai", adress: "yam 2", pon: 332524, avgMarks: 70, departure_date: "---", active: true, route: 3, Year: Year.C,tests:[{code:1, description: "mate",  date:'02/03/2023',mark: 90}]}
]
@Injectable()
export class StudentService{
    getStudent():Student[]{
    return STUDENTS;  
    }
}
