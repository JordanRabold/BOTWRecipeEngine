USE DBBOTWRecipeEngine

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