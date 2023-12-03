import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Student } from '../student.model';
import { outputAst } from '@angular/compiler';
@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
})
export class StudentDetailsComponent {
  
  @Input() student: Student | undefined;
  @Output()
  saveNewStudent: EventEmitter<Student> = new EventEmitter();
  save() {
    if (this.student)
      this.saveNewStudent.emit(this.student);
  }
}
