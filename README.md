# Allie Laptop Store

## Goal

There are 3 parts to this challenge. The Goal is to get as far as you possibly can in 2 hours. We do not expect everything to be completed.

### Part 1 - Minimum Viable Product

Create .NET MVC/API project (or .NET Core)

API:
  - Create a Model and populate a List`<T>` from the following [API]
  - Create an API action method that returns ^ model

MVC: Create 3 Views (.cshtml) with the following minimal requirements:
  - HomePage (Product List): make an API call to the API you created above.
  - Individual Product Page: (each product linked from home list). Should have 'add to cart' button/link somewhere on page.
  - Shopping Cart: should be able to view Items which have been placed in the cart. For this step, this can be generated from a hard-coded model. Shopping Cart page should also provide a total dollar amount of all items * quantity in the cart.
  
> The overriding goal for this exercise is functionality
> and code organization. Feel free to add any styling that you like, however, 
> no styling at all is also perfectly acceptable.
  
### Part 2 - Functionality

  - Add functionality to add/remove items from the Cart (cart model should no longer be hard coded)
  - Persist shopping cart across page refreshes/sessions  
  - Add ability to filter Product List page with a search term (search name, description, color, etc.)
  - Add ability to filter Product List page by items on sale
  - Add ability to sort the Product List by price  

## Completion

Please submit a pull request here when you are done.

[API]: <https://api.bestbuy.com/v1/products((categoryPath.id=abcat0502000))?apiKey=3z6a6dd2jyfjtrpkhdbsaayk&sort=bestSellingRank.asc&show=bestSellingRank,color,customerReviewAverage,image,name,onSale,percentSavings,regularPrice,salePrice,shortDescription,sku,thumbnailImage,longDescription&pageSize=100&format=json>
[AngularJS]: <http://angularjs.org>
