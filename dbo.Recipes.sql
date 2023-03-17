CREATE TABLE [dbo].[Recipes] (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [RecipeName]    NVARCHAR (MAX) NOT NULL,
    [Num_Hearts]    NVARCHAR (MAX) NOT NULL,
    [Ingredient4]   NVARCHAR (MAX) NOT NULL,
    [RecipePicture] NVARCHAR (MAX) NOT NULL,
    [Ingredient1]   NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Ingredient2]   NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Ingredient3]   NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_Recipes] PRIMARY KEY CLUSTERED ([ID] ASC)
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

