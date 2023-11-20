# Shop

# # תיאור הפרויקט

# תיאור הפרויקט
## ישויות
- עובד
- ספק
- מוצר
## לעובד ROUTES  מיפוי
 - שליפת רשימת עובדים 
GET https://localhost:7275/api/Student
- שליפת עובד לפי מזהה
 GET https://localhost:7275/api/Student/1
- הוספת עובד
POST  https://localhost:7275/api/Student
- עדכון עובד
PUT https://localhost:7275/api/Student/1
- עדכון סטטוס סטודנט
PUT  https://localhost:7275/api/Student/1/status
- מחיקת עובד
DELETE https://localhost:7275/api/Student/1
##  ספק ROUTES  מיפוי
 - שליפת רשימת ספקים
GET https://localhost:7275/api/Teacher
- שליפת ספק לפי מזהה
 GET   https://localhost:7275/api/Teacher/1
- הוספת ספק
POST  https://localhost:7275/api/Teacher
- עדכון ספק
PUT  https://localhost:7275/api/Teacher/1
- עדכון סטטוס מרצה
PUT    https://localhost:7275/api/Teacher/1/status
- מחיקת ספק
DELETE   https://localhost:7275/api/Teacher/1
##   מוצר ROUTES  מיפוי
 - שליפת רשימת מוצרים
GET https://localhost:7275/api/Course
- שליפת מוצר  לפי מחיר
 GET   https://localhost:7275/api/Course/1
- הוספת מוצר
POST  https://localhost:7275/api/Course
- עדכון מוצר
PUT https://localhost:7275/api/Course/1
- מחיקת מוצר
DELETE   https://localhost:7275/api/Course/1
