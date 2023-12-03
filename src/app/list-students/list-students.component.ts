import { Component, EventEmitter, Output } from '@angular/core';
import { Student, Year } from '../student.model';
import { NgFor } from '@angular/common';
import { Test } from '../models/test.model';
import { StudentService } from '../student.service';
@Component({
  selector: 'app-list-students',
  templateUrl: './list-students.component.html',
})
export class ListStudentsComponent {
  @Output()
  outputStudentTest: EventEmitter<Student> = new EventEmitter();
  students: Student[] =this._studentService. getStudent();
  constructor(private _studentService:StudentService){}
  selectStudent: Student| undefined ;
  deleteStudent(student: Student) {
    let x = this.students.indexOf(student);
    this.students.splice(x, 1);
  }
  showDetails(s: Student) {
    this.outputStudentTest.emit(s);
    this.selectStudent = s;
  }
  addStudent(student: Student) {
    let sUpdate=this.students.findIndex(x=>x.id==student.id)
    if (sUpdate==-1) {   
      alert("add student");
    }
    else 
    {
      this.students.splice(sUpdate, 1);
      alert("the detail update")
    }
    
    this.students.push(student);
    this.selectStudent = undefined;
    this.outputStudentTest.emit(this.selectStudent);
  }
  show() {
    this.selectStudent = new Student(this.students.length+1, "name", "famalyname", "adress", 123456789,0,true,Year.A,1,undefined);
    this.outputStudentTest.emit(this.selectStudent);

  }
}
