import { useState, useEffect } from "react";
import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";
import Menu from "./Menu";
import ParticipateDay from "./ParticipateDay";
import ParticipateWeek from "./ParticipateWeek";
import AddGuestModal from "./AddGuestModal";
import AddGuest from "./AddGuest";
import ListMyGuests from "./ListMyGuests";
import lasagna from "../lasagne.jpg"
import Image from "next/image";

export default async function MenuList() {
  const cookieStore = cookies();
  const supabase = createClient(cookieStore);
  const { data: menus, error } = await supabase.from("menus").select();
// .eq("published", true)
  
  if (error) {
    console.error("error fetching data:", error);
    return <div>Error fetching data!</div>
  }

  
    var currentDate = new Date();

    var startDate = new Date(currentDate.getFullYear(), 0, 1);

    var days = Math.floor((currentDate.getTime() - startDate.getTime()) /
    (24 * 60 * 60 * 1000));
    var weekNumber  = Math.ceil(days / 7);
 
// Display the calculated result       
// console.log(weekNumber);

  //this gets the user from authentication
  const {
    data: { user },
  } = await supabase.auth.getUser();

  //get the userid
  const userId = user?.id;

// console.log(userId)
// const [currentDateNow, setCurrentDateNow] = useState(new Date());

  return (
    <section className="gap-10 w-full">
      <div className="w-full">
      <h1 className="text-3xl w-28 mx-auto">Uge {weekNumber}</h1>
      </div>
      <section className="flex justify-center gap-10 mt-5">        
        <div className="flex flex-col w-3/4">
        <div className="flex ml-auto mr-auto flex-row w-3/4 justify-end">
        {/* <AddGuestModal  userId={{userId}}/> */}
        <p className="mr-3">Deltag alle dage</p>
        {/* <ParticipateWeek menus={[menus]}/> */}
        </div>
        {menus
            .filter((menu) => {
              const menuDate = new Date(menu.menu_date);
              const menuWeekNumber = getWeekNumber(menuDate);
              return menuWeekNumber === weekNumber;
            })
            .sort((a, b) => new Date(a.menu_date).getTime() - new Date(b.menu_date).getTime())
            .map((menu) => (
              <div
                key={menu.menu_id}
                className="relative my-5 p-5 flex flex-row  ml-auto mr-auto w-3/4 mx  border-solid border-2 border-sky-500"
              >
                <Menu menu={menu} />
                <div className="absolute flex flex-row right-2">
                  <ParticipateDay menu={menu} userId={{ userId }} />
                </div>
              </div>
            ))}
        <div className="relative my-5 p-5 flex flex-row  ml-auto mr-auto w-3/4 mx">
        <div className="flex flex-col">
        <div className="flex flex-row">
        <h1 className="mr-2">Søndag</h1>
        <h1 className="mr-2">24.12</h1>
        <h1 className="mr-2">12:00 - 13:00</h1>
        </div>
        <div className="flex flex-row mt-2">
                {/* <img src="../lasagna.jpg" className="w-25"/> */}
                <Image src={lasagna} alt="lasagna"/>
                {/* <h1>{dish.dish_id}</h1>
                <h1>{dish.dish_title}</h1> */}
                <div className="pl-5 flex-col">
                <h1 className="text-2xl mb-5">Lasagne</h1>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book</p>
                </div>
            </div>
        </div>
        </div>
        
        </div>

      </section>
      <AddGuest userId={{userId}}/>
      <ListMyGuests userId={{userId}}/>
    </section>
  );
}
// Helper function to get the week number from a date
function getWeekNumber(date: Date): number {
  const startDate = new Date(date.getFullYear(), 0, 1);
  const days = Math.floor((date.getTime() - startDate.getTime()) / (24 * 60 * 60 * 1000));
  return Math.ceil(days / 7);
}
