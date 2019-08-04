import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import { InvestorDetails } from './investor-details';

@Injectable()
export class InvestorService {
  baseUrl: string = 'http://localhost:5001/api';
  constructor(
    private httpClient: Http
  ) { }

  // Service method to retrieve Country list
  public getCountryList(): Observable<any> {
    return this.httpClient.get(this.baseUrl + '/address/countryList');
  }

  // Service method to retrieve States
  public getStates(): Observable<any> {
    return this.httpClient.get(this.baseUrl + '/address/states');
  }

  // Service method to save Investor details
  public saveApplication(investorDetails: InvestorDetails): Observable<any> {
    return this.httpClient.post(this.baseUrl + '/investor/create', investorDetails);
  }

  // Service method to retrieve States
  public checkStateAndPostcode(state: string, postcode: string): Observable<any> {
    return this.httpClient.get(this.baseUrl + `/address/isStateAndPostcodeValid?state=${state}&postcode=${postcode}`);
  }
}