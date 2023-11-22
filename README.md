# Shop

# תיאור הפרויקט
## ישויות
- עובד
- ספק
- מוצר
## מיפוי Route לעובד
 - שליפת רשימת עובדים 
GET https://localhost:7188/api/Employee
- שליפת עובד לפי מזהה
 GET https://localhost:7188/api/Employee/1
- הוספת עובד
POST  https://localhost:7188/api/Employee
- עדכון עובד
PUT https://localhost:7188/api/Employee/1
- מחיקת עובד
DELETE https://localhost:7188/api/Employee/1
## מיפוי Route לספק
 - שליפת רשימת ספקים
GET https://localhost:7188/api/Provider
- שליפת ספק לפי מזהה
GET https://localhost:7188/api/Provider/1
- הוספת ספק
POST https://localhost:7188/api/Provider
- עדכון ספק
PUT https://localhost:7188/api/Provider/1
- מחיקת ספק
DELETE https://localhost:7188/api/Provider/1
##   מיפוי Route למוצר
 - שליפת רשימת מוצרים
GET https://localhost:7188/api/Product
- שליפת מוצר  לפי מזהה
 GET https://localhost:7188/api/Product/1
- הוספת מוצר
POST  https://localhost:7188/api/Product
- עדכון מוצר
PUT https://localhost:7188/api/Product/1
- עדכון מחיר מוצר
https://localhost:7188/api/Product/1/price
- מחיקת מוצר
DELETE   https://localhost:7188/api/Product/1
