let addToList = (product) => {
    $("#productList")
        .append($("<li>").html(product.Name, product.Price));
}

let loadProducts = () => {
    $.ajax({
        url: "/api/ProductApi",
        //because there is no type, we know it is a get
        //think of the controller as entry point to apps
        dataType: "json",
        success: (allProducts) => {
            allProducts.map((p) => { addToList(p); });
        }
    })
}

loadProducts();





//function GetAllProducts()
//{
//    jQuery.support.cors = true;
//    $.ajax({
//        url: 'http://localhost:52188/api/get',
//        type: 'GET',
//        datatype: 'json',
//        success: function (data) {
//            ConsoleWrite(data)
//        },
//        error: function () {
//            alert("Error");
//        }

//    });
//}