import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListStudentsComponent } from './list-students/list-students.component';
import { Student } from './student.model';
import { StudentDetailsComponent } from './student-details/student-details.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { StudentFromMdComponent } from './student-from-md/student-from-md.component';
import { TestListComponent } from './test-list/test-list.component';
import { StudentService } from './student.service';



@NgModule({
  declarations: [
    AppComponent,
    ListStudentsComponent,
    StudentDetailsComponent,
    StudentFromMdComponent,
    TestListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule,ReactiveFormsModule],
  providers: [StudentService],

  bootstrap: [AppComponent]
})
export class AppModule { }
