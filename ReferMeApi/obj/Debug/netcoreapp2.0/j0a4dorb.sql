ALTER TABLE `Emails` ADD `VerificationCode` varchar(255) NOT NULL DEFAULT '';

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20180815175614_AddVerificationCodeToEmailsTable', '2.1.1-rtm-30846');

