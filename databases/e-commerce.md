
### I saw a video about e-commerce database diagram on youtub from the *[database Star channel]*, and i wrote the sql statments for it using MSSQL.
(diagram and the video link is attached below the file)

```sql


use ECOMMERCE;

create table country(
country_id int  IDENTITY(1,1) primary key not null,
country_name VARCHAR(255) not null,
);

go 


create table address(
address_id int identity(1,1) primary key not null,
unite_number varchar(50),
street_number varchar(50),
address_line1 varchar(50),
addrees_line2 varchar(50),
city varchar(50),
region varchar(50),
postal_code int,
country_id int  not null,
FOREIGN KEY (country_id) REFERENCES country(country_id)
);
go


CREATE TABLE site_user(
user_id int IDENTITY(1,1) primary key not null,
email_address varchar(100) not null,
phone_number varchar(20),
password varchar(50) not null
)
go

create table user_address(
user_id int not null,
address_id int not null,
is_default BIT not null default 1,

FOREIGN KEY (user_id) references site_user(user_id),
FOREIGN KEY (address_id) references address(address_id)
)
go



create table product_category(
category_id int primary key Identity(1,1) not null,
parent_category_id int,
category_name varchar(100) not null,
FOREIGN KEY(parent_category_id) references product_category(category_id)
);
go

create table promotion(
promotion_id int identity(1,1) primary key not null,
name varchar(50) not null,
description  varchar(200) not null,
discount_rate  decimal(5,2) not null,
start_date date not null,
end_date date not null
);
go

create table promotion_category(
category_id int not null,
promotion_id int not null,
foreign key(category_id) references product_category(category_id),
foreign key(promotion_id) references promotion(promotion_id)
)
go

create table product(
product_id int identity(1,1) primary key not null,
category_id int not null,
name varchar(100) not null,
description varchar(500) not null,
product_image varchar(500)
foreign key(category_id) references product_category(category_id)
);
go

create table variation(
variation_id int identity(1,1) primary key not null,
category_id int not null,
name varchar(50) not null,
foreign key(category_id) references product_category(category_id)
);
go

create table variation_option(
variation_option_id int identity(1,1) primary key not null,
variation_id int not null,
name varchar(50) not null,
foreign key(variation_id) references variation(variation_id)
)
go

create table product_item(
product_item_id int identity(1,1) primary key not null,
product_id int not null,
SKU varchar(100) unique,
qty_in_stock int  not null,
product_image varchar(500),
price decimal(10,2) not null,

foreign key(product_id) references product(product_id)
);
go

create table product_configuration(
product_item_id int not null,
variation_option_id int not null,

foreign key(product_item_id) references product_item(product_item_id),
foreign key(variation_option_id) references variation_option(variation_option_id)
)
go

create table shopping_cart(
shopping_cart_id int identity(1,1) primary key not null,
user_id int not null,
foreign key(user_id) references site_user(user_id)
)
go


create table shopping_cart_item(
shopping_cart_item_id int identity(1,1) primary key not null,
cart_id int not null,
product_item_id int not null,
qty int not null,
foreign key(cart_id) references shopping_cart(shopping_cart_id),
foreign key(product_item_id) references product_item(product_item_id)
)
go

create table payment_type(
payment_type_id int identity(1,1) primary key not null,
value varchar(50)
)
go


create table order_status(
order_status_id int identity(1,1) primary key not null,
status varchar(50) not null
)
go

create table shipping_method(
shipping_method_id int identity(1,1) primary key not null,
name varchar(100) not null,
price decimal(8,2)  not null
)
go


create table user_paymnet_method(
user_paymnet_method_id int identity(1,1) primary key not null,
user_id int not null,
payment_type_id int not null,
provider varchar(100),
account_number varchar(500) not null,
expire_date date not null,
is_default Bit default 1,
foreign key(user_id) references site_user(user_id),
foreign key(payment_type_id) references payment_type(payment_type_id)
)
go








create table shop_order(
shop_order_id int identity(1,1) primary key not null,
user_id int not null,
order_date date not null,
payment_method_id int not null,
shipping_address_id  int not null,
shipping_method_id  int not null,
order_total decimal(15,2) not null,
order_status_id  int not null,

foreign key(user_id) references site_user(user_id),
foreign key(payment_method_id) references user_paymnet_method(user_paymnet_method_id),
foreign key(shipping_address_id) references address(address_id),
foreign key(shipping_method_id) references shipping_method(shipping_method_id),
foreign key(order_status_id) references order_status(order_status_id),

)
go


create table order_line(
order_line_id int identity(1,1) primary key not null,
product_item_id int not null,
order_id int not null,
qty int not null,
price decimal(10,2) not null,

foreign key(product_item_id) references product_item(product_item_id),
foreign key(order_id) references shop_order(shop_order_id),
)
go

create table user_review(
user_review_id int identity(1,1) primary key not null,
user_id int not null,
ordered_product_id int not null,
rating_value decimal(1,0) not null,
comment varchar(1000),

foreign key(user_id) references site_user(user_id),
foreign key(ordered_product_id) references shop_order(shop_order_id),
)
go
```



[source video](https://www.youtube.com/watch?v=1HamqOuv2Cw&ab_channel=DatabaseStar)

## Diagram


![erd_ecommerce_database](https://user-images.githubusercontent.com/73998098/215359452-a883563e-61c6-4935-b786-9057d50fa74f.png)


