CREATE PROCEDURE [usp_GetAllProducts]
SELECT  * FROM Products
WHERE ProductName = @ProductName
ORDER BY ProductName