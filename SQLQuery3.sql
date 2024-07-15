INSERT INTO Users (FirstName, Lastname, Password, Email, Fund, Type, Status)
VALUES ('Guy','Mizrahi' ,ENCRYPTBYPASSPHRASE('Password', 'Guy1309'), 'Guy132000@gmail.com',0.00,'Users',1 )

INSERT INTO Users (FirstName, Lastname, Password, Email, Fund, Type, Status)
VALUES ('Adi','Offek' ,ENCRYPTBYPASSPHRASE('Password', 'ADI094'), 'adioffek@gmail.com',0.00,'Users',1 )

INSERT INTO Users (FirstName, Lastname, Password, Email, Fund, Type, Status)
VALUES ('admin','admin' ,ENCRYPTBYPASSPHRASE('Password', 'Admin10'), 'admin',NULL,'admin',1 )

INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Bepanthen','Bayer' , 27.0, 9.0 ,1,13-09-2027,'bepanthen.jpg',1 )
INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Paracetamol','Teva' , 35.0, 9.0 ,1,13-09-2027,'paracetamol.jpg',1 )
INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Protein bar','All-in' , 17.0, 7.0 ,1,13-09-2027,'allin.jpg',1 )
INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Head& Shoulders','Procter & Gamble' , 20.0, 5.0 ,1,13-09-2027,'head&shoulders.jpg',1 )
INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Ciprlex','Novartis Pharmaceuticals Corporation' , 30.0, 6.0 ,1,13-09-2027,'ciprlex.jpg',1 )
INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Otrivin','Teva' , 22.0, 7.0 ,1,13-09-2027,'otrivin.jpg',1 )
INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Rennie','Teva' , 37.0, 10.0 ,1,13-09-2027,'rennie.jpg',1 )
INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Strepsils','Teva' , 23.0, 4.0 ,1,13-09-2027,'strepsils.jpg',1 )
INSERT INTO Medicines(Name, Manufacturer, UnitPrice, Discount, Quantity, ExpDate, ImageUrl, Status)
VALUES ('Solaray','Ogden' , 29.0, 0.0 ,1,13-09-2027,'solaray.jpg',1 )
GO


INSERT INTO Orders (UserID, OrderNo, OrderTotal, OrderStatus,CreatedOn)
VALUES(17,'57A29D33-8D55-4B30-AEED-0D9C16C6140A',188.00,'Pending',GETDATE())
GO

INSERT INTO OrderItems (OrderID, MedicineId, UnitPrice, Discount,Quantity, TotalPrice)
VALUES(14,'7','27.00','2.43','1','24.57')


INSERT INTO OrderItems (OrderID, MedicineId, UnitPrice, Discount,Quantity, TotalPrice)
VALUES(14,'9','17.00','3.57','3','47.43')

INSERT INTO OrderItems (OrderID, MedicineId, UnitPrice, Discount,Quantity, TotalPrice)
VALUES(14,'15','29.00','0.00','4','116.00')