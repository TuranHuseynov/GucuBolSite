let topphot = document.querySelector(".topph img");
let allphot = document.querySelectorAll(".btmph img");
let headsc = document.getElementById("top");
let horses = document.getElementById("guller");

for(photos of allphot){
	photos.addEventListener("click",function(){
		topphot.setAttribute("src", this.getAttribute("src"))
	})
	
}



document.body.addEventListener("mousemove",function(){
	setTimeout(function() {
			headsc.style.display = 'block';
			horses.style.display = 'none';

		}, 5600);
		
})