# Shop

@@ -1,4 +1,5 @@
# Shop# תיאור הפרויקט
# School
# תיאור הפרויקט
## ישויות
- סטודנט
- מרצה
- קורס
## לסטודנט ROUTES  מיפוי
 - שליפת רשימת סטודנטים 
GET https://localhost:7275/api/Student
- שליפת סטודנט לפי מזהה
 GET https://localhost:7275/api/Student/1
- הוספת סטודנט
POST  https://localhost:7275/api/Student
- עדכון סטודנט
PUT https://localhost:7275/api/Student/1
- עדכון סטטוס סטודנט
PUT  https://localhost:7275/api/Student/1/status
- מחיקת סטודנט
DELETE https://localhost:7275/api/Student/1
##  מרצה ROUTES  מיפוי
 - שליפת רשימת מרצים
GET https://localhost:7275/api/Teacher
- שליפת מרצה לפי מזהה
 GET   https://localhost:7275/api/Teacher/1
- הוספת מרצה
POST  https://localhost:7275/api/Teacher
- עדכון מרצה
PUT  https://localhost:7275/api/Teacher/1
- עדכון סטטוס מרצה
PUT    https://localhost:7275/api/Teacher/1/status
- מחיקת מרצה
DELETE   https://localhost:7275/api/Teacher/1
##   קורס ROUTES  מיפוי
 - שליפת רשימת קורסים
GET https://localhost:7275/api/Course
- שליפת קורס  לפי מזהה
 GET   https://localhost:7275/api/Course/1
- הוספת קורס
POST  https://localhost:7275/api/Course
- עדכון קורס
PUT https://localhost:7275/api/Course/1
- מחיקת קורס
DELETE   https://localhost:7275/api/Course/1
