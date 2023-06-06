SELECT p.ProductName, c.CategoryName FROM ProductsCategories
JOIN products p ON p.Id=ProductsCategories.ProductId
LEFT JOIN categories c ON c.Id=ProductsCategories.CategoryId;