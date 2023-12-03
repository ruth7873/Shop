import { Test } from "./models/test.model";



export class Student{
  id:number;
  name:string="";
  famalyName:string="";
  adress:string="";
  pon:number=0;
  avgMarks:number=0;
  departure_date:string="--";
  active:boolean=true;
  Year:Year;
  route:number;
  tests:Test[];
constructor(id:number,name:string,famalyName:string,adress:string,pon:number,avgMarks:number,active:boolean=true,Year:Year,route:number,  tests:Test[]){
  this.id=id;
  this.name=name;
  this.famalyName=famalyName;
  this.adress=adress;
  this.pon=pon;
  this.avgMarks=avgMarks;
  this.active=active;
  this.Year=Year;
  this.route=route;
  this.tests=tests;
}
}
export enum Year {
  A = 1,
  B = 2,
  C = 3
}