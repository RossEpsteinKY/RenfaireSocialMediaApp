import {Component, OnInit} from '@angular/core';
import {HttpClientModule} from "@angular/common/http";
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Renfaire Social Media Site';
  users: any;

  constructor(private http: HttpClient) {

  }

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this.http.get('https://localhost:5001/api/users').subscribe(
      response => {
        this.users = response;
      }, error => {
        console.log(error)
      });
  }

}


