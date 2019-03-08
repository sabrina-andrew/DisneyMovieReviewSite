# Disney Movie Review Site

Build a review site. The data gathered will help them gain insight into their customer base and the products they have come to enjoy
Development of a MVC Web Application by a team that practices agile methodology, utilizes test driven design, and values clean code


### Unit Tests

Create an MVC with appropriate unit testing.

### Review Class
*Create Review class
- Its properties should include: Id (make this of type int and just use arbitrary, unique numbers for these ids), Title, Image url, Review category, and Content
- And whatever other things you'd like to include. Some ideas: Date or Description/synopsis.
- As a stretch Task you could add tags (which should probably be a List).


### Review Repository

*Create Review Repository class for the content reviews.
* This class should be configured so that it will be injected into ReviewsController.
* It should have a constructor that creates your Review instances and populates a Dictionary that stores your reviews, using each review's id as the key.
* It should have a method to get all reviews
* It should have a method to find one review by id

### Review Controller

*Create Review Controller
* It should have a method mapped to a url that puts all of your reviews into the model, and returns a "reviews" View.
* It should have a method mapped to a url including an id parameter that puts one of your reviews into the model, forwarding to a "review" View. This method should expect an "id" query parameter in order to select a specific review.

### Category Class

*Create Category Class
* Should be an EF Entity
* Contains a property referencing the Reviews it contains.
* Configures an appropriate EF relationship to its reviews.

### Category Repository

*Create a categroy repo
* Should be an EF Entity
* Configures an EF relationship to its associated category.

### Styling

* There is a page that lists review categories, each of which links to the (details) page for a specific category.
* There is a page that lists the reviews for a chosen category, each of which links to the (details) page for a specific review.
* Each review detail page has a link to the page for its category.

### Add, Edit, Delete

* Add CRUD (Create, Read, Update and Delete) actions to the appropriate controller and repository.
* Make sure the controller has bList of all Product categoriesoth Get and Post method types for these actions

## Navigation

*Ensure the user can logically navigate to all the functions you have added to your program (some of these functions may be shown on the same page)

* List of all Product reviews
* Details for a Product review
* List of all Product categories
* Details for a Product category, with a list of all Product reviews that fall under that category

#### Interfaces

* Add Interfaces for all Repositories and add some Controller tests using the Interfaces and NSubstitute. The number of tests is not important, just try to get some coverage with this new tool.


