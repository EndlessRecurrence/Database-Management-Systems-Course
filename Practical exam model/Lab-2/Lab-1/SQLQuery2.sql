BEGIN TRANSACTION
UPDATE Posts SET PostText = 'THIS IS THE NEW UPDATED  POST' WHERE PId = 1
COMMIT TRANSACTION


