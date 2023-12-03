import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Student, Year } from '../student.model';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ROUTES } from '../models/route.model';

@Component({
  selector: 'app-student-from-md',
  templateUrl: './student-from-md.component.html',
  styleUrls:['./student-from-md.component.css']

})
export class StudentFromMdComponent {
Rotes=ROUTES;
year = Year;
private _student: Student|undefined;
public get student() : Student {
  return this._student; 
  
} 
@Input()
public set student (v : Student) {
  this._student = v;
  if(this._student !=undefined)
  {
    this.studentForm = new FormGroup(
      {
        "name": new FormControl(this.student.name, Validators.required),
        "famalyName": new FormControl(this.student.famalyName, Validators.required),
        "adress": new FormControl(this.student.adress, [Validators.minLength(3), Validators.required]),
        "pon": new FormControl(this.student.pon,[Validators.required,Validators.maxLength(10),Validators.minLength(9)]),
        "active": new FormControl(this.student.active, Validators.required),
        "avgMarks": new FormControl(this.student.avgMarks),
        "routeType": new FormControl(this.student.route,Validators.required),
        "year": new FormControl(this.student.Year,  Validators.required),
        
      }
    )

  } 
}

@Output()
saveNewStudent: EventEmitter<Student> = new EventEmitter();
  
studentForm: FormGroup= new FormGroup({});;
  save() {

    this.student.name=this.studentForm.controls["name"].value;
      this.student.pon=this.studentForm.controls["pon"].value;
      this.student.famalyName=this.studentForm.controls["famalyName"].value;
      this.student.adress=this.studentForm.controls["adress"].value;
      this.student.active=this.studentForm.controls["active"].value;
      this.student.avgMarks=this.studentForm.controls["avgMarks"].value;
      this.student.route=this.studentForm.controls["routeType"].value;
      this.student.Year=this.studentForm.controls["year"].value;
      this.saveNewStudent.emit(this.student);
    //ngthis.student.name=this.studentForm?.controls['name'];
      
  }
}
