import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";
import Button from "./ParticipateDay";
import Dish from "./Dish";

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
    let date = getDate.slice(8, 10);

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
        <div className="flex flex-row">
        <h1 className="mr-2">{DayName}</h1>
        <h1 className="mr-2">{date}.</h1>
        {/* <h1 className="mr-2">{menu.menu_title}</h1> */}
        <h1 className="mr-2">{startTime} - {endTime}</h1>
        <h1>{menu.menu_title}</h1>
        </div>
        {menudishs?.map((menudish) => (
            <div key={menudish.menu_id}>
                <Dish menudish={menudish}/>
            </div>
        ))}
        {dishData?.map((dish) => (
            <div key={dish.dish_id} className="flex flex-row mt-2">
                {/* <img src={publicURL} className="w-25"/> */}
                {/* <h1>{dish.dish_id}</h1>
                <h1>{dish.dish_title}</h1> */}
                <div className="pl-5 flex-col">
                <h1 className="text-2xl mb-5">{dish.dish_title}</h1>
                <p>{dish.dish_description}</p>
                </div>
            </div>
        ))}
        </div>
        {/* <h1 className="mr-4">Deltag</h1> */}
        {/* <Button/> */}
        </div>
    );
  }
  
  export default Menu;