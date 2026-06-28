# Externalized Configuration

## Template Repository

The template repository for this assignment is: [externalized-configuration](https://github.com/Ivy-Tech-SDEV243-Assignment-Templates/externalized-configuration).

**_Do not work directly from the starter template if using CodeSpaces! make sure to first click "Use this template" and create a repository in your personal account, then create the CodeSpace from your repository page._**

## Introduction

The purpose of this assignment is to learn how to externalize configuration to make the code more flexible, and improve safety of provided configuration values.

This assignment has a video walkthrough to accompany the written instructions. Some checkpoints may require you to complete work on your own.

Be sure to match any provided video output exactly, including:

- filenames
- code
- comments
- commit messages
- screenshots

## Learning Goals

- Distinguish between settings that belong in configuration versus values that belong in source code
- Use a configuration file to store and retrieve application settings
- Recognize the advantages or using strongly typed configuration bindings

## Checkpoints

### Check1: Moving application constants to externalized configuration settings

The `Program.cs` file currently contains a number of constants that are used to configure the application. These constants are hardcoded in the source code.

Because these form part of the application's configuration rather than business logic, they should be externalized to a configuration file. We will start by moving the constants to an `appsettings.json` file.

_Deliverables:_

- `appsettings.json`: Added new configuration file.
- Commit with message "check1".

### Check2: Reading configuration settings with string keys

The `appsettings.json` file now contains the configuration settings. We will read this configuration file with a thin loader class so that we can use them in the `Program.cs` file.

_Deliverables:_

- `AppSettingsLoader.cs`: Added new class to load configuration settings.
- `Program.cs`: Modified to use the new class to load configuration settings.
- Commit with message "check2".

### Check3: Adding type safety with a settings type

The settings implementation so far does not provide any details on what data type is expected for each setting. In this checkpoint we will map the application.json settings to a custom settings type.

_Deliverables:_

- `AppSettings.cs`: Added new class to hold the configuration settings.
- `Program.cs`: Modified to use the new class to hold the configuration settings.
- Commit with message "check3".

### Check4: Loading the settings object at startup

For this final checkpoint we will modify AppSettingsLoader to return an instance of the settings object. This enforces type safety at application startup, when the file is first read.

We will run the test suite to confirm that the application still works as expected.

_Note:_ It is a good idea to run the test suite as you are working after each change. We have not done so in the video to keep it shorter.

_Deliverables:_

- `AppSettingsLoader.cs`: Modified to return an instance of the settings object.
- `Program.cs`: Modified to use the new settings object.
- Commit with message "check4".

## Submission

After completing all checkpoints:

- Confirm that the checkpoints exist in the remote repository
- Check the rubric to see if all requirements were met
- Submit the URL to the root of your GitHub Repository, `https://github.com/[your-username]]/externalized-configuration`
