# Midterm350 Project

This project is a Web Application that views the Veterinarians and Patients. There are two pages that link to either the Veterinarians or Patients.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

In order to run this project, you will need:

* Visual Studio
* SQL Server and SSMS
* Chrome-based browser (Edge, Chrome, etc.)

### Configure database

In order to get the web application up and running, please add the database to your SQL Server.

```
1. Update the connection string in appsetting.json to your local server
2. Run update-database. The migrations should already be created.
3. Verify the Database is set up and that you can run the application.
```

## Usage

### NOTE: In order to create, edit, or delete a Veterinarian, you must login to the admin account. The admin account is below:

Username: admin@sample.com | Password: !Admin1234

You may notice at the home page it'll say "Welcome, Admin!" instead of just "Welcome."

In the top left of the Nav Bar, there are two links. One is a dropdown labeled "Meet our Vets!" and the other labeled "View our Patients!" goes to the index of the Patients.

### Veternarian Controller

In "Meet our Vets!", the dropdown shows "View all Vets," which goes to the index of vets, then each of the names of the vets. Clicking on one of the names goes to the details page of that vet.

In the index page, there is a list of all the vets, where it shows their name, years of experience, bio, and image. There are links to the details of each vet, and you can either edit or delete the vet.

To create a vet, click on "Create New" below the "All our Vets!" title. You must fill out all fields and make sure all of them are filled out. Once they are filled out, you can click on "Create." If you change your mind, you can click on "Back to List."

In the details page of the vet, it shows the image of the vet, their name, their years of experience, and their bio. There are two buttons below that are "Edit," which edits the current vet, and "Back to List," which goes to the index of vets.

In the edit page, you can change any of the values, just like the create page.

If you delete a vet, there is a page beforehand that makes sure the vet you're deleting is the one you want to delete. Click on the red "Delete" button to delete the vet, or "Back to list" to go back to the index.

### Patient Controller

In the index page, there is a list of all the patients, where it shows their name, species, breed, age, medications, medical history and image. There are links to the details of each patient, and you can either edit or delete the patient.

To create a patient, click on "Create New" below the "All our Patients!" title. You must fill out all fields and make sure all of them are filled out. Once they are filled out, you can click on "Create." If you change your mind, you can click on "Back to List."

In the details page of the patient, it shows the image of the patient, their name, their age, and everything else (species, breed, medication and medical history). There are two buttons below that are "Edit," which edits the current patient, and "Back to List," which goes to the index.

In the edit page, you can change any of the values, just like the create page.

If you delete a patient, there is a page beforehand that makes sure the patient you're deleting is the one you want to delete. Click on the red "Delete" button to delete the patient, or "Back to list" to go back to the index.



### NOTE: to add or change an image to either the vet or patient, it takes a URL of an image. Search for the image you're looking for, then right click on the image and click on "Copy Image Link." Then paste the URL in the "ImgURL" text box.
