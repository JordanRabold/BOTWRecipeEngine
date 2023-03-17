DROP DATABASE DBBOTWRecipeEngine

CREATE DATABASE DBBOTWRecipeEngine

USE DBBOTWRecipeEngine

DROP TABLE Botw_Recipes

CREATE TABLE Botw_Recipes(
	ID INT,
	RecipeName VARCHAR(40),
	Ingredient1 VARCHAR(40),
	Ingredient2 VARCHAR(40),
	Ingredient3 VARCHAR(40),
	Ingredient4 VARCHAR(40),
	Num_Hearts FLOAT,
	Recipe_Image VARBINARY(max)
);

INSERT INTO Botw_Recipes 
	VALUES(1, 
		   'Pumpkin Stew', 
		   'Fortified Pumpkin',
		   'Goat Butter',
		   'Fresh Milk',
		   'Tabantha Wheat',
		   4, 
		   (SELECT * FROM OPENROWSET(BULK N'C:\Users\jorda\Documents\BOTWImages\Pumpkinsoup.jpg', SINGLE_BLOB) as T1)
);

SELECT RecipeName,
	Ingredient1,
	Ingredient2,
	Ingredient3,
	Ingredient4,
	Num_Hearts,
	Recipe_Image
FROM Botw_Recipes
WHERE RecipeName = 'Pumpkin stew'
