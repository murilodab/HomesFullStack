import { Injectable } from '@angular/core';
import { HousingLocation } from './housinglocation';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { MessageService } from './message.service';




@Injectable({
  providedIn: 'root'
})




export class HousingService {
  
  private headers = new HttpHeaders()
    
    .set('Access-Control-Allow-Origin', 'http://localhost:4200')
    .set('Access-Control-Allow-Credentials', 'true');
    

  constructor(private http: HttpClient,
    private messageService: MessageService) { }

  /** Log a Service message with the MessageService */
  private log(message: string) {
    this.messageService.add(`HeroService: ${message}`);
  }

  private apiUrl = "http://localhost:5149/api/Homes";


  getAllHousingLocations(): Observable<HousingLocation[]> {

    

    return this.http.get<HousingLocation[]>(this.apiUrl, {headers: this.headers});

  }

}
