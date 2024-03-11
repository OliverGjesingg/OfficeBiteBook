import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";
import Button from "./ParticipateDay";
import Dish from "./Dish";
import lasagna from "../lasagne.jpg"
import Image from "next/image";


interface MenuProps {
    menu: {
      menu_id: any;
      menu_title: any;
      published: any; 
      menu_date: any;
      menu_start_time: any;
      menu_end_time: any;
    };
  }
  
  async function Menu({ menu }: MenuProps) {
    const cookieStore = cookies();
    const supabase = createClient(cookieStore);

    const {data: menudishs} = await supabase.from("menu_dish").select().eq("menu_id", menu.menu_id);

    let getDate = menu.menu_date ? menu.menu_date : ""; // set default value if undefined
    let sliceDate = getDate.slice(5, 10);
    // Parse the date string into a Date object
    const date = new Date(sliceDate);
    // Format the date as "day month year"
    const formattedDate = `${date.getDate()}-${date.getMonth() + 1}`;

    let getStartTime = menu.menu_start_time ? menu.menu_start_time : "";
    let startTime = getStartTime.slice(0, 5);

    let getEndTime = menu.menu_end_time ? menu.menu_end_time : "";
    let endTime = getEndTime.slice(0, 5);


    // let sdasdasd = new Date(getDate)

    const { data: dishData, error: dishError } = await supabase.from("dishes").select().eq("menu_id", menu.menu_id);
    console.log(dishData + "this is the data")

    let fullDate = new Date(getDate)
    const day = fullDate.getDay();
    const dayNames = ["Søndag","Mandag","Tirsdag","Onsdag","Torsdag","Fredag","Lørdag"]
    let DayName = dayNames[day]
    

    

    return (
      <div className="flex flex-row">
        
      <div className="flex flex-col">
        <div className="flex lg:flex-row text-sm sm:text-base sm:mt-0 mt-7">
        <h1 className="mr-1">{DayName}</h1>
        <h1 className="mr-2">{formattedDate}</h1>
        <h1 className="mr-2">{startTime} - {endTime}</h1>
        <h1>{menu.menu_title}</h1>
        </div>
        {dishData?.map((dish) => (
            <div key={dish.dish_id} className="flex flex-col sm:flex-row mt-2">
                {/* <img src={publicURL} className="w-25"/> */}
                <Image className="w-1/2 sm:w-1/3 shrink-0" src={lasagna} alt="lasagna"/>

                <div className="sm:pl-5 flex-col w-full">
                <h1 className="text-2xl mb-1 ">{dish.dish_title}</h1>
                <p>{dish.dish_description}</p>
                </div>
            </div>
        ))}
        </div>
        </div>
    );
  }
  
  export default Menu;