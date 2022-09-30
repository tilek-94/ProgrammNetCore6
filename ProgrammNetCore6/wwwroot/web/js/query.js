 function funcBefore(){
      $("#information").text("Издөө...");
    }   

    function funcSuccess(data){
     $("#information").html(data);

      }

 function LoadHitProduct(){
  var admin='';
       $.ajax({
                    url:"/categories/HitProduct",
                    type:"POST",
                    data:({zakaz:admin}),
                    dataType:"html",
                    success:funcSuccess

                });
       


            }

   
function LoadSaleProduct(){
    var admin='';
       $.ajax({
                    url:"/categories/SaleProduct?Product=1",
                    type:"POST",
                    data:({zakaz:admin}),
                    dataType:"html",
                    success: function funcaleProduct(data){
                               $("#information2").html(data);
                               }

                });
       


            }

function AddToCart(id,Count){
     //alert(id);
    var admin=id;
    $.ajax({
                    url:"/addToCart?ProductId="+admin,
                    type:"POST",
                    data:({zakaz:admin}),
                    dataType:"html",
                    success: function funcaleProduct(data){
                               $("#CountProduct").html(data);
                               }
                    
                });
       


            }

            $(document).ready(function(){
               $("#search1").on("keyup",function(){
                    var query = $(this).val();
                   
                    $.ajax({
                         url:"/product/search",
                         type: "POST",
                         data:{searchDate:query},
                         dataType:"html",
                         success:function(data){
                              $('#dropdown').html(data);
                         }
                    });
               });
               //end ajax call
          });
            

