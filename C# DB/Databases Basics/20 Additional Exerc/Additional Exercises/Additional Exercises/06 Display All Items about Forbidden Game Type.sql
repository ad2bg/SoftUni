SELECT * FROM GameTypeForbiddenItems

SELECT i.Name AS [Item],
       i.Price AS [Price],
	   i.MinLevel AS [MinLevel],
	   gt.Name AS [Forbidden Game Type]
FROM Items AS i
LEFT JOIN GameTypeForbiddenItems AS gtfi ON gtfi.ItemId = i.Id
LEFT JOIN GameTypes AS gt ON gt.Id = gtfi.GameTypeId
ORDER BY [Forbidden Game Type] DESC, [Item]