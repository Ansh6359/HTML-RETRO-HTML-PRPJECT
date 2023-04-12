const navLinks = document.querySelectorAll('nav a[href^="#"]');   //this is js file

//give global variable to show main line
navLinks.forEach(link => {
  link.addEventListener('click', function (event) {   //added link tag to give finishinh
    event.preventDefault();
    const target = document.querySelector(this.getAttribute('href'));
    target.scrollIntoView({
      behavior: 'smooth'
    });
  });
});
