import { Component } from '@angular/core';
import { Student } from './student.model';


@Component({
  selector: 'app-root',
  templateUrl:'./app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  titel:string ="hello";
  D:Date=new Date();
  t:number=this.D.getHours();
  s:string=this.getTime();
  getTime(){
    time:
    if (this.t<12)
    return "good morning";
    else if(this.t<18)
    {
      return"good afternoom";
    }
    return "good night";
    

  }
  student:Student
  tachTest(s:Student)
  {
    this.student=s;

  }
}
