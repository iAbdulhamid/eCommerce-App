import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  categories: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getCategories();
  }

  getCategories() {
    this.http.get('http://localhost:5000/api/category').subscribe(categories => {
      this.categories = categories;
    }, error => console.log(error));
  }
}
