/*Set box-sizing to border-box for all elements */
* {
    box-sizing: border-box;
    margin: 0;
    padding: 0;
}

/* Set default styles for the body */
body {
    font-family: Arial, sans-serif;
    font-size: 16px;
    line-height: 1.5;
}

/* Set color to black */
a {
    color: #000;
    text-decoration: none;
}

ul {
    list-style: none;
}

/*use it to give styling to image*/
img {
    max-width: 100%;
    height: auto;
}

/*Set background color to light gray */
header {
    background-color: #f2f2f2;
    padding: 20px;
}

nav ul {
    display: flex;
    justify-content: space-between;
}

nav ul li {
    margin-right: 20px;
}

/* Set margin to the right of navigation items */
nav ul li:last-child {
    margin-right: 0;
}

nav ul li a:hover {
    text-decoration: underline;
}

/*here is  hero section */
.hero {
    background-color: #eee;
    padding: 50px;
    text-align: center;
}

.hero h1 {
    font-size: 36px;
    margin-bottom: 20px;
}

.hero p {
    margin-bottom: 30px;
}

.hero button {
    background-color: #000;
    color: #fff;
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    font-size: 18px;
    cursor: pointer;
}

.hero button:hover {
    background-color: #fff;
    color: #000;
    border: 1px solid #000;
}

/* Featured products section */
.featured {
    padding: 50px;
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
}

.product {
    background-color: #f2f2f2;
    margin-bottom: 30px;
    width: 45%;
    padding: 20px;
    text-align: center;
}

.product h3 {
    font-size: 24px;
    margin-bottom: 10px;
}

.product p {
    margin-bottom: 20px;
}

.product button {
    background-color: #000;
    color: #fff;
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    font-size: 18px;
    cursor: pointer;
}

/* Set background color to light gray */
.product button:hover {
    background-color: #fff;
    color: #000;
    border: 1px solid #000;
}

/* Testimonials section */
.testimonials {
    background-color: #eee;
    padding: 50px;
}

.testimonial {
    background-color: #f2f2f2;
    padding: 20px;
    text-align: center;
    margin-bottom: 30px;
}

.testimonial p {
    margin-bottom: 20px;
}

.testimonial h3 {
    font-size: 18px;
}

/* Footer */
footer {
    background-color: #f2f2f2;
    padding: 20px;
    text-align: center;
}

footer p {
    margin-top: 10px;
}

.price {
    font-size: 24px;
    color: green;
    font-weight: bold;
}
