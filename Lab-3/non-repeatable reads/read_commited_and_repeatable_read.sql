SET TRANSACTION ISOLATION LEVEL READ COMMITTED
BEGIN TRANSACTION
SELECT * FROM Album WHERE AlbumId = 17
WAITFOR DELAY '00:00:10'
SELECT * FROM Album WHERE AlbumId = 17
COMMIT TRANSACTION

SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
BEGIN TRANSACTION
SELECT * FROM Album WHERE AlbumId = 17
WAITFOR DELAY '00:00:10'
SELECT * FROM Album WHERE AlbumId = 17
COMMIT TRANSACTION
