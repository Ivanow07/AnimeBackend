CREATE TABLE Users (
    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL,
    Password TEXT NOT NULL,
    Rank TEXT DEFAULT 'default',
    IPAddress TEXT
);

CREATE TABLE Animes (
    AnimeId INTEGER PRIMARY KEY AUTOINCREMENT,
    Title TEXT NOT NULL,
    Description TEXT
);

CREATE TABLE VoiceChannels (
    ChannelId INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL
);

CREATE TABLE UserChannels (
    UserId INTEGER,
    ChannelId INTEGER,
    FOREIGN KEY(UserId) REFERENCES Users(UserId),
    FOREIGN KEY(ChannelId) REFERENCES VoiceChannels(ChannelId)
);
