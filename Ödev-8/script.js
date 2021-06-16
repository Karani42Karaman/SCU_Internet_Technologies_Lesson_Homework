var q1 = document.getElementById("q1");
var q2 = document.getElementById("q2");
var q3 = document.getElementById("q3");
var q4 = document.getElementById("q4");
var q5 = document.getElementById("q5");



var next1 = document.getElementById('next1');
var next2 = document.getElementById('next2');
var next3 = document.getElementById('next3');
var next4 = document.getElementById('next4');


document.addEventListener('DOMContentLoaded', function() {
    let query = window.matchMedia("(max-width: 767px)");

    if (query.matches) {


        var a = next1.onclick = function() {
            q1.style.left = "-650px";
            q2.style.left = "15px";
        }

        next2.onclick = function() {
            q2.style.left = "-650px";
            q3.style.left = "15px";
        }

        next3.onclick = function() {
            q3.style.left = "-650px";
            q4.style.left = "15px";
        }

        next4.onclick = function() {
            q4.style.left = "-650px";
            q5.style.left = "15px";
        }

    } else {


        var a = next1.onclick = function() {
            q1.style.left = "-650px";
            q2.style.left = "50px";
        }
        next2.onclick = function() {
            q2.style.left = "-650px";
            q3.style.left = "50px";
        }

        next3.onclick = function() {
            q3.style.left = "-650px";
            q4.style.left = "50px";
        }

        next4.onclick = function() {
            q4.style.left = "-650px";
            q5.style.left = "50px";
        }
    }
});



function uncheck() {
    var rad = document.getElementById('rd')
    rad.removeAttribute('checked')
}
document.addEventListener('DOMContentLoaded', function() {
    const main = document.querySelector('body')
    const toggleSwitch = document.querySelector('.slider')
    toggleSwitch.addEventListener('click', () => {
        main.classList.toggle('dark-theme')
    })
})