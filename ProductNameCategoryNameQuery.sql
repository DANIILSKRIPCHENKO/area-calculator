SELECT Products.Name, Categories.Name from Products
LEFT JOIN ProductsCategories pc ON Products.Id = pc.ProductId
LEFT JOIN Categories ON Categories.Id = pc.CategoryId