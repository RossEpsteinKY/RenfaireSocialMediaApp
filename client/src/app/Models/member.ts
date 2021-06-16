import {Photo} from "./photo";

export interface Member {
  id:           number;
  photoUrl:     string;
  userName:     string;
  age:          number;
  knownAs:      string;
  createdAt:    Date;
  lastActive:   Date;
  gender:       string;
  pronouns:     string;
  introduction: string;
  interests:    string;
  homeFaire:    string;
  actType:      string;
  city:         string;
  state:        string;
  country:      string;
  photos:       Photo[];
}


