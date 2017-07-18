let addToList = (product) => {
    $("#productList")
        .append($("<li>").html(product.Name, product.Price));
}

//let addToList = (product) => {
//   // baseUrl = "@Url.Action("Home","ProductPage")";
//    $("#productList")
//        .append($("<li>")
//            .append($("<a>").html(product.Name, product.Price).attr("href", window.location.href = "View/Home/ProductPage")));
////            .append($("<a>").html(product.Name, product.Price).attr("href", window.location.href = '@Url.Action("Home","ProductPage"')));
////            .append($("<a>").html(product.Name, product.Price).attr("href", baseUrl)));
//}

let loadProducts = () => {
    $.ajax({
        url: "/api/ProductApi",
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