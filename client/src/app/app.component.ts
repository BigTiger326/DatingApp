import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Dating App';
  user : any;

  constructor(private http:HttpClient){}

  ngOnInit(): void {

    this.http.get('https://localhost:7128/api/user').subscribe({
      next : response => this.user = response,
      error: error => console.log(error),
      complete:()=>console.log('Request has complete')
      
    })

  }
}
