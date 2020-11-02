var slideIndex = 2;
//0:boy 1:girl 2:robot
showSlides(slideIndex);

function showSlides(n) {
  
    document.getElementById("boy").style.display = "none";
    document.getElementById("girl").style.display = "none";
    document.getElementById("robot").style.display = "none";
    if (n == 0)
       {
            document.getElementById("boy").style.display = "inline";
            return;
       }
    if (n == 1)
        {
            document.getElementById("girl").style.display = "inline";
            return;
        }

    document.getElementById("robot").style.display = "inline";

    
}

function increase() {
    slideIndex = slideIndex+1;
    if (slideIndex < 0) slideIndex = 2;
    if (slideIndex > 2) slideIndex = 0;
    showSlides(slideIndex);
}
function decrease() {
    slideIndex = slideIndex-1;
    if (slideIndex < 0) slideIndex = 2;
    if (slideIndex > 2) slideIndex = 0;
    showSlides(slideIndex);
}

